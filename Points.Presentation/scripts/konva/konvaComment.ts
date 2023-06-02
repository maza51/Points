import {IComment} from "../types/IComment.js";


declare const Konva: any;

export class KonvaComment{
    private comment: IComment;
    private element: any;
    
    constructor(comment: IComment) {
        this.comment = comment;
    }
    
    public getElement(): any {
        if (this.element !== undefined) {
            return this.element;
        }

        const group = new Konva.Group();
        
        const comment = new Konva.Text({
            text: this.comment.text,
            padding: 4,
            align: "center",
            fontSize: 20,
            fontFamily: "Calibri",
            fill: this.comment.backgroundColor === "#FFFFFF" ? "#000000" : "#FFFFFF",
            contentEditable: true
        });

        const rect = new Konva.Rect({
            x: comment.x() - 2,
            y: comment.y() - 2,
            stroke: "#555",
            strokeWidth: 2,
            fill: this.comment.backgroundColor,
            width: comment.width() + 4,
            height: comment.height() + 4,
            cornerRadius: 2,
        });

        group.add(rect);
        group.add(comment);
        
        group.offsetX(rect.width() / 2);
        
        this.element = group;
        
        return this.element;
    }
}