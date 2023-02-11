"use strict";
exports.__esModule = true;
exports.AppPageComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var page_model_1 = require("./page.model");
var AppPageComponent = (function () {
    function AppPageComponent() {
        this.changed = new core_1.EventEmitter();
        this.pages = 0;
        this._count = 0;
        this._page = new page_model_1.PageModel();
    }
    Object.defineProperty(AppPageComponent.prototype, "count", {
        get: function () {
            return this._count;
        },
        set: function (count) {
            this._count = count;
            this.setPages();
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(AppPageComponent.prototype, "page", {
        get: function () {
            return this._page;
        },
        set: function (page) {
            this._page = page;
            this.setPages();
        },
        enumerable: false,
        configurable: true
    });
    AppPageComponent.prototype.change = function (index) {
        this.page.index = index;
        this.changed.emit();
    };
    AppPageComponent.prototype.setPages = function () {
        this.pages = Math.ceil(this.count / this.page.size);
    };
    tslib_1.__decorate([
        core_1.Input("count")
    ], AppPageComponent.prototype, "count");
    tslib_1.__decorate([
        core_1.Input("page")
    ], AppPageComponent.prototype, "page");
    tslib_1.__decorate([
        core_1.Output()
    ], AppPageComponent.prototype, "changed");
    AppPageComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-page",
            templateUrl: "./page.component.html",
            standalone: true,
            imports: [
                common_1.CommonModule
            ]
        })
    ], AppPageComponent);
    return AppPageComponent;
}());
exports.AppPageComponent = AppPageComponent;
//# sourceMappingURL=page.component.js.map