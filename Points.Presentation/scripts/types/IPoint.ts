import {IComment} from "./IComment";

export interface IPoint {
    id: number;
    positionX: number;
    positionY: number;
    radius: number;
    color: string;
    comments: IComment[];
}