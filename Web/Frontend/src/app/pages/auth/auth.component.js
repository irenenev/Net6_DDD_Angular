"use strict";
exports.__esModule = true;
exports.AppAuthComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var button_component_1 = require("src/app/components/button/button.component");
var password_input_component_1 = require("src/app/components/input/password.input.component");
var text_input_component_1 = require("src/app/components/input/text.input.component");
var label_component_1 = require("src/app/components/label/label.component");
var AppAuthComponent = (function () {
    function AppAuthComponent(appAuthService) {
        this.appAuthService = appAuthService;
        this.form = core_1.inject(forms_1.FormBuilder).group({
            login: ["admin@email.com", forms_1.Validators.required],
            password: ["admin", forms_1.Validators.required]
        });
    }
    AppAuthComponent.prototype.auth = function () {
        this.appAuthService.auth(this.form.value);
    };
    AppAuthComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-auth",
            templateUrl: "./auth.component.html",
            standalone: true,
            imports: [
                common_1.CommonModule,
                forms_1.ReactiveFormsModule,
                button_component_1.AppButtonComponent,
                password_input_component_1.AppInputPasswordComponent,
                text_input_component_1.AppInputTextComponent,
                label_component_1.AppLabelComponent
            ]
        })
    ], AppAuthComponent);
    return AppAuthComponent;
}());
exports.AppAuthComponent = AppAuthComponent;
//# sourceMappingURL=auth.component.js.map