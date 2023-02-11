"use strict";
exports.__esModule = true;
exports.AppInputTextComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var input_component_1 = require("./input.component");
var AppInputTextComponent = (function (_super) {
    tslib_1.__extends(AppInputTextComponent, _super);
    function AppInputTextComponent() {
        var _this = _super.call(this, "text") || this;
        _this.autofocus = false;
        _this.disabled = false;
        return _this;
    }
    AppInputTextComponent_1 = AppInputTextComponent;
    var AppInputTextComponent_1;
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputTextComponent.prototype, "autofocus");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputTextComponent.prototype, "class");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputTextComponent.prototype, "disabled");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputTextComponent.prototype, "formControlName");
    tslib_1.__decorate([
        core_1.Input()
    ], AppInputTextComponent.prototype, "text");
    AppInputTextComponent = AppInputTextComponent_1 = tslib_1.__decorate([
        core_1.Component({
            selector: "app-input-text",
            templateUrl: "./input.component.html",
            standalone: true,
            providers: [{ provide: forms_1.NG_VALUE_ACCESSOR, useExisting: AppInputTextComponent_1, multi: true }],
            imports: [
                common_1.CommonModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule
            ]
        })
    ], AppInputTextComponent);
    return AppInputTextComponent;
}(input_component_1.AppInputComponent));
exports.AppInputTextComponent = AppInputTextComponent;
//# sourceMappingURL=text.input.component.js.map