"use strict";
exports.__esModule = true;
exports.AppNavComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var AppNavComponent = (function () {
    function AppNavComponent(appAuthService, router) {
        var _this = this;
        this.appAuthService = appAuthService;
        this.router = router;
        this.userLoggedIn = false;
        this.signout = function () { return _this.appAuthService.signout(); };
    }
    AppNavComponent.prototype.ngOnInit = function () {
        this.userLoggedIn = this.appAuthService.authenticated();
        this.router.routeReuseStrategy.shouldReuseRoute = function () { return false; };
    };
    AppNavComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-nav",
            templateUrl: "./nav.component.html",
            standalone: true,
            imports: [
                router_1.RouterModule,
                common_1.CommonModule
            ]
        })
    ], AppNavComponent);
    return AppNavComponent;
}());
exports.AppNavComponent = AppNavComponent;
//# sourceMappingURL=nav.component.js.map