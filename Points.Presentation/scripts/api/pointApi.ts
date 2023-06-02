import {IPoint} from "../types/IPoint.js";

export const pointsApi = {
    async getPoints(): Promise<IPoint[]> {
        const response = await fetch("/api/points");
        const points = await response.json();
        return points as IPoint[];
    },

    async createPoint(): Promise<IPoint> {
        const response = await fetch("/api/points", {
            method: "POST",
        });
        const createdPoint = await response.json();
        return createdPoint as IPoint;
    },
    
    async updatePoint(point: IPoint): Promise<IPoint> {
        const response = await fetch("/api/points", {
            method: "PUT",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(point)
        });
        const updatedPoint = await response.json();
        return updatedPoint as IPoint;
    },

    async deletePoint(id: number): Promise<void> {
        await fetch(`/api/points/${id}`, { method: "DELETE" });
    }
}