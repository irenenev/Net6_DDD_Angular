"use strict";
exports.__esModule = true;
exports.AppComponent = void 0;
var AppComponent = (function () {
    function AppComponent() {
    }
    Object.defineProperty(AppComponent.prototype, "value", {
        get: function () { return this._value; },
        set: function (value) {
            if (this.value === value)
                return;
            this._value = value;
            if (this.onChange)
                this.onChange(value);
        },
        enumerable: false,
        configurable: true
    });
    AppComponent.prototype.registerOnChange = function (onChange) { this.onChange = onChange; };
    AppComponent.prototype.registerOnTouched = function (_) { };
    AppComponent.prototype.writeValue = function (value) { this.value = value; };
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=component.js.map