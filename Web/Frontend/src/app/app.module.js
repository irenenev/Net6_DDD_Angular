"use strict";
exports.__esModule = true;
exports.AppModule = void 0;
var tslib_1 = require("tslib");
var http_1 = require("@angular/common/http");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var platform_browser_1 = require("@angular/platform-browser");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var app_error_handler_1 = require("./app.error.handler");
var app_http_interceptor_1 = require("./app.http.interceptor");
var app_routes_1 = require("./app.routes");
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = tslib_1.__decorate([
        core_1.NgModule({
            bootstrap: [app_component_1.AppComponent],
            declarations: [app_component_1.AppComponent],
            imports: [
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                platform_browser_1.BrowserModule,
                http_1.HttpClientModule,
                router_1.RouterModule.forRoot(app_routes_1.ROUTES)
            ],
            providers: [
                { provide: core_1.ErrorHandler, useClass: app_error_handler_1.AppErrorHandler },
                { provide: core_1.APP_INITIALIZER, useFactory: function (_) { return function () { }; }, multi: true },
                { provide: http_1.HTTP_INTERCEPTORS, useClass: app_http_interceptor_1.AppHttpInterceptor, multi: true }
            ]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map