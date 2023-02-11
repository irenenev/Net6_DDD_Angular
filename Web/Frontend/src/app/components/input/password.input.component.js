"use strict";
exports.__esModule = true;
exports.AppInputPasswordComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var input_component_1 = require("./input.component");
var AppInputPasswordComponent = (function (_super) {
    tslib_1.__extends(AppInputPasswordComponent, _super);
    function AppInputPasswordComponent() {
        var _this = _super.call(this, "password") || this;
        _this.autofocus = false;
        _this.disabled = false;
        return _this;
    }
    AppInputPasswordComponent_1 = AppInputPasswordComponent;
    var AppInputPasswordComponent_1;
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputPasswordComponent.prototype, "autofocus");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputPasswordComponent.prototype, "class");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputPasswordComponent.prototype, "disabled");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputPasswordComponent.prototype, "formControlName");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputPasswordComponent.prototype, "text");
    AppInputPasswordComponent = AppInputPasswordComponent_1 = tslib_1.__decorate([
        core_1.Component({
            selector: "app-input-password",
            templateUrl: "./input.component.html",
            standalone: true,
            providers: [{ provide: forms_1.NG_VALUE_ACCESSOR, useExisting: AppInputPasswordComponent_1, multi: true }],
            imports: [
                common_1.CommonModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule
            ]
        })
    ], AppInputPasswordComponent);
    return AppInputPasswordComponent;
}(input_component_1.AppInputComponent));
exports.AppInputPasswordComponent = AppInputPasswordComponent;
//# sourceMappingURL=password.input.component.js.map