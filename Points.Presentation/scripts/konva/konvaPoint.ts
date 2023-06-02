import {IPoint} from "../types/IPoint.js";
import {pointsApi} from "../api/pointApi.js";
import {KonvaComment} from "./konvaComment.js";
import {IComment} from "../types/IComment.js";

declare const Konva: any;

export class KonvaPoint {
    private point: IPoint;
    private element: any;
    
    constructor(point: IPoint) {
        this.point = point;
    }
    
    public getElement(): any {
        if (this.element !== undefined) {
            return this.element;
        }
        
        const group = new Konva.Group({
            draggable: true,
            x: this.point.positionX,
            y: this.point.positionY
        });

        this.element = group;
        
        const circle = new Konva.Circle({
            radius: this.point.radius,
            fill: this.point.color,
        });

        circle.on("click", async () => {
            let tmpColor = this.getRandomColor();
            this.point.color = tmpColor;
            await this.update();
            circle.setFill(tmpColor);
        });

        group.on("dblclick", async () => {
            await this.delete();
            group.destroy();
        });

        group.on("dragend", async () => {
            this.point.positionX = group.x();
            this.point.positionY = group.y();
            await this.update();
        });
        
        group.add(circle);

        if (this.point.comments !== null) {
            for (const comment of this.point.comments) {
                this.addComment(comment);
            }
        }
        
        return this.element;
    }
    
    public addComment(comment: IComment): void {
        const konvaComment = new KonvaComment(comment);

        const commentsCount = this.element.find("Text").length;
        const element = konvaComment.getElement();
        element.y(20 + commentsCount * 36);
        
        this.element.add(element);
    }

    private async delete(): Promise<void> {
        try{
            await pointsApi.deletePoint(this.point.id);
        }catch (error){
            console.log(error);
        }
    }

    private async update(): Promise<void> {
        try{
            await pointsApi.updatePoint(this.point);
        }catch (error){
            console.log(error);
        }
    }

    private getRandomColor() {
        let letters = "0123456789ABCDEF";
        let color = "#";
        for (let i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }
}