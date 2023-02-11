"use strict";
exports.__esModule = true;
exports.AppInputComponent = void 0;
var tslib_1 = require("tslib");
var component_1 = require("src/app/components/component");
var AppInputComponent = (function (_super) {
    tslib_1.__extends(AppInputComponent, _super);
    function AppInputComponent(type) {
        var _this = _super.call(this) || this;
        _this.type = type;
        return _this;
    }
    AppInputComponent.prototype.input = function ($event) {
        this.value = $event.target.value;
    };
    return AppInputComponent;
}(component_1.AppComponent));
exports.AppInputComponent = AppInputComponent;
//# sourceMappingURL=input.component.js.map