"use strict";
exports.__esModule = true;
exports.AppListComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var grid_component_1 = require("./grid/grid.component");
var router_1 = require("@angular/router");
var AppListComponent = (function () {
    function AppListComponent() {
    }
    AppListComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-list",
            templateUrl: "./list.component.html",
            standalone: true,
            imports: [
                router_1.RouterModule,
                grid_component_1.AppListGridComponent
            ]
        })
    ], AppListComponent);
    return AppListComponent;
}());
exports.AppListComponent = AppListComponent;
//# sourceMappingURL=list.component.js.map