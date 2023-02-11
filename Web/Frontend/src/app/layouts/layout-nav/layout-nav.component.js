"use strict";
exports.__esModule = true;
exports.AppLayoutNavComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var footer_component_1 = require("src/app/layouts/footer/footer.component");
var header_component_1 = require("src/app/layouts/header/header.component");
var nav_component_1 = require("src/app/layouts/nav/nav.component");
var AppLayoutNavComponent = (function () {
    function AppLayoutNavComponent() {
    }
    AppLayoutNavComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-layout-nav",
            templateUrl: "./layout-nav.component.html",
            standalone: true,
            imports: [
                router_1.RouterModule,
                footer_component_1.AppFooterComponent,
                header_component_1.AppHeaderComponent,
                nav_component_1.AppNavComponent
            ]
        })
    ], AppLayoutNavComponent);
    return AppLayoutNavComponent;
}());
exports.AppLayoutNavComponent = AppLayoutNavComponent;
//# sourceMappingURL=layout-nav.component.js.map