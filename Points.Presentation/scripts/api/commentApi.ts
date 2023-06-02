import {IComment} from "../types/IComment.js";

export const commentsApi = {
    async createComment(model: ICreateCommentModel): Promise<IComment> {
        const response = await fetch("/api/comments", {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(model)
        });
        const createdPoint = await response.json();
        return createdPoint as IComment;
    }
}

export interface ICreateCommentModel {
    text: string;
    backgroundColor: string;
    pointId: number;
}