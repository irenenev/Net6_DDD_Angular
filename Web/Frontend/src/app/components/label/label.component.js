"use strict";
exports.__esModule = true;
exports.AppLabelComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppLabelComponent = (function () {
    function AppLabelComponent() {
    }
    tslib_1.__decorate([
        core_1.Input()
    ], AppLabelComponent.prototype, "for");
    tslib_1.__decorate([
        core_1.Input()
    ], AppLabelComponent.prototype, "text");
    AppLabelComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-label",
            templateUrl: "./label.component.html",
            standalone: true
        })
    ], AppLabelComponent);
    return AppLabelComponent;
}());
exports.AppLabelComponent = AppLabelComponent;
//# sourceMappingURL=label.component.js.map