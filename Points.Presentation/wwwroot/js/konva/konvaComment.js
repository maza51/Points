var KonvaComment = /** @class */ (function () {
    function KonvaComment(comment) {
        this.comment = comment;
    }
    KonvaComment.prototype.getElement = function () {
        if (this.element !== undefined) {
            return this.element;
        }
        var group = new Konva.Group();
        var comment = new Konva.Text({
            text: this.comment.text,
            padding: 4,
            align: "center",
            fontSize: 20,
            fontFamily: "Calibri",
            fill: this.comment.backgroundColor === "#FFFFFF" ? "#000000" : "#FFFFFF",
            contentEditable: true
        });
        var rect = new Konva.Rect({
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
    };
    return KonvaComment;
}());
export { KonvaComment };
//# sourceMappingURL=konvaComment.js.map