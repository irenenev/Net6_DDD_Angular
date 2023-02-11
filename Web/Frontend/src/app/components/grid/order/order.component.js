"use strict";
exports.__esModule = true;
exports.AppOrderComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var order_model_1 = require("./order.model");
var AppOrderComponent = (function () {
    function AppOrderComponent() {
        this.changed = new core_1.EventEmitter();
    }
    AppOrderComponent.prototype.click = function () {
        var _a;
        this.order = (_a = this.order) !== null && _a !== void 0 ? _a : new order_model_1.OrderModel();
        this.order.property = this.property;
        this.order.ascending = !this.order.ascending;
        this.changed.emit();
    };
    tslib_1.__decorate([
        core_1.Output()
    ], AppOrderComponent.prototype, "changed");
    tslib_1.__decorate([
        core_1.Input()
    ], AppOrderComponent.prototype, "order");
    tslib_1.__decorate([
        core_1.Input()
    ], AppOrderComponent.prototype, "property");
    tslib_1.__decorate([
        core_1.Input()
    ], AppOrderComponent.prototype, "text");
    AppOrderComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-order",
            templateUrl: "./order.component.html",
            standalone: true,
            imports: [
                common_1.CommonModule
            ]
        })
    ], AppOrderComponent);
    return AppOrderComponent;
}());
exports.AppOrderComponent = AppOrderComponent;
//# sourceMappingURL=order.component.js.map