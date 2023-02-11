"use strict";
exports.__esModule = true;
exports.AppButtonComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppButtonComponent = (function () {
    function AppButtonComponent() {
        this.disabled = false;
    }
    tslib_1.__decorate([
        core_1.Input()
    ], AppButtonComponent.prototype, "disabled");
    tslib_1.__decorate([
        core_1.Input()
    ], AppButtonComponent.prototype, "text");
    AppButtonComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-button",
            templateUrl: "./button.component.html",
            standalone: true
        })
    ], AppButtonComponent);
    return AppButtonComponent;
}());
exports.AppButtonComponent = AppButtonComponent;
//# sourceMappingURL=button.component.js.map