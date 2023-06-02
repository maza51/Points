var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (g && (g = 0, op[0] && (_ = 0)), _) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
import { pointsApi } from "../api/pointApi.js";
import { KonvaComment } from "./konvaComment.js";
var KonvaPoint = /** @class */ (function () {
    function KonvaPoint(point) {
        this.point = point;
    }
    KonvaPoint.prototype.getElement = function () {
        var _this = this;
        if (this.element !== undefined) {
            return this.element;
        }
        var group = new Konva.Group({
            draggable: true,
            x: this.point.positionX,
            y: this.point.positionY
        });
        this.element = group;
        var circle = new Konva.Circle({
            radius: this.point.radius,
            fill: this.point.color,
        });
        circle.on("click", function () { return __awaiter(_this, void 0, void 0, function () {
            var tmpColor;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        tmpColor = this.getRandomColor();
                        this.point.color = tmpColor;
                        return [4 /*yield*/, this.update()];
                    case 1:
                        _a.sent();
                        circle.setFill(tmpColor);
                        return [2 /*return*/];
                }
            });
        }); });
        group.on("dblclick", function () { return __awaiter(_this, void 0, void 0, function () {
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0: return [4 /*yield*/, this.delete()];
                    case 1:
                        _a.sent();
                        group.destroy();
                        return [2 /*return*/];
                }
            });
        }); });
        group.on("dragend", function () { return __awaiter(_this, void 0, void 0, function () {
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        this.point.positionX = group.x();
                        this.point.positionY = group.y();
                        return [4 /*yield*/, this.update()];
                    case 1:
                        _a.sent();
                        return [2 /*return*/];
                }
            });
        }); });
        group.add(circle);
        if (this.point.comments !== null) {
            for (var _i = 0, _a = this.point.comments; _i < _a.length; _i++) {
                var comment = _a[_i];
                this.addComment(comment);
            }
        }
        return this.element;
    };
    KonvaPoint.prototype.addComment = function (comment) {
        var konvaComment = new KonvaComment(comment);
        var commentsCount = this.element.find("Text").length;
        var element = konvaComment.getElement();
        element.y(20 + commentsCount * 36);
        this.element.add(element);
    };
    KonvaPoint.prototype.delete = function () {
        return __awaiter(this, void 0, void 0, function () {
            var error_1;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        _a.trys.push([0, 2, , 3]);
                        return [4 /*yield*/, pointsApi.deletePoint(this.point.id)];
                    case 1:
                        _a.sent();
                        return [3 /*break*/, 3];
                    case 2:
                        error_1 = _a.sent();
                        console.log(error_1);
                        return [3 /*break*/, 3];
                    case 3: return [2 /*return*/];
                }
            });
        });
    };
    KonvaPoint.prototype.update = function () {
        return __awaiter(this, void 0, void 0, function () {
            var error_2;
            return __generator(this, function (_a) {
                switch (_a.label) {
                    case 0:
                        _a.trys.push([0, 2, , 3]);
                        return [4 /*yield*/, pointsApi.updatePoint(this.point)];
                    case 1:
                        _a.sent();
                        return [3 /*break*/, 3];
                    case 2:
                        error_2 = _a.sent();
                        console.log(error_2);
                        return [3 /*break*/, 3];
                    case 3: return [2 /*return*/];
                }
            });
        });
    };
    KonvaPoint.prototype.getRandomColor = function () {
        var letters = "0123456789ABCDEF";
        var color = "#";
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    };
    return KonvaPoint;
}());
export { KonvaPoint };
//# sourceMappingURL=konvaPoint.js.map