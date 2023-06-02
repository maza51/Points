import {IPoint} from "./types/IPoint.js";
import {pointsApi} from "./api/pointApi.js";
import {KonvaPoint} from "./konva/konvaPoint.js";
import {commentsApi, ICreateCommentModel} from "./api/commentApi.js";

declare const Konva: any;

export class App {
    private stage: any;
    private layer: any;
    private points: IPoint[];

    constructor() {
        this.stage = null;
        this.layer = null;
        this.points = [];
    }

    async init(): Promise<void> {
        this.points = await pointsApi.getPoints();
        this.setupForm();
        this.setupKonva();
        this.renderPoints();
        this.setupEventListeners();
    }

    private setupForm(): void {
        const pointSelect = document.getElementById("point-select") as HTMLSelectElement;

        while (pointSelect.firstChild) {
            pointSelect.removeChild(pointSelect.firstChild);
        }
        
        for (const point of this.points) {
            console.log(point);
            const newOption = document.createElement("option") as HTMLOptionElement;
            newOption.value = point.id.toString();
            newOption.text = point.id.toString();

            pointSelect.add(newOption);
            console.log(newOption);
        }
    }

    private setupKonva(): void {
        this.stage = new Konva.Stage({
            container: "stage-container",
            width: 930,
            height: 930,
        });

        this.layer = new Konva.Layer();
        this.stage.add(this.layer);
    }

    private renderPoints(): void {
        for (const point of this.points) {
            this.renderPoint(point);
        }
    }

    private renderPoint(point: IPoint): void {
        const konvaPoint = new KonvaPoint(point);
        this.layer.add(konvaPoint.getElement());
    }

    private setupEventListeners(): void {
        const addButton = document.getElementById("add-button");
        addButton.addEventListener("click", async () => {
            try{
                const createdPoint = await pointsApi.createPoint();
                this.points.push(createdPoint);
                this.renderPoint(createdPoint);
                this.setupForm();
            }catch (error){
                console.log(error);
            }
        });
        
        const addCommentButton = document.getElementById("add-comment-button");
        addCommentButton.addEventListener("click", async () => {

            const pointSelect = document.getElementById("point-select") as HTMLSelectElement;
            const commentInput = document.getElementById("comment-input") as HTMLInputElement;
            const colorSelect = document.getElementById("color-select") as HTMLSelectElement;
            
            const comment: ICreateCommentModel = {
                text: commentInput.value,
                backgroundColor: colorSelect.value,
                pointId: parseInt(pointSelect.value)
            }
            
            try{
                const createdComment = await commentsApi.createComment(comment);
                location.reload();
            }catch (error){
                console.log(error);
            }
        });
    }
}

const app = new App();
app.init();
