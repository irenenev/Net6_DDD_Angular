"use strict";
exports.__esModule = true;
exports.AppHomeComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var img_list_component_1 = require("./img-list/img-list.component");
var router_1 = require("@angular/router");
var AppHomeComponent = (function () {
    function AppHomeComponent() {
    }
    AppHomeComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-home",
            templateUrl: "./home.component.html",
            standalone: true,
            imports: [
                router_1.RouterModule,
                img_list_component_1.AppImgListComponent
            ]
        })
    ], AppHomeComponent);
    return AppHomeComponent;
}());
exports.AppHomeComponent = AppHomeComponent;
//# sourceMappingURL=home.component.js.map