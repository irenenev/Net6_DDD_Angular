"use strict";
exports.__esModule = true;
exports.AppErrorHandler = void 0;
var tslib_1 = require("tslib");
var http_1 = require("@angular/common/http");
var core_1 = require("@angular/core");
var AppErrorHandler = (function () {
    function AppErrorHandler(appModalService) {
        this.appModalService = appModalService;
    }
    AppErrorHandler.prototype.handleError = function (error) {
        if (error instanceof http_1.HttpErrorResponse) {
            switch (error.status) {
                case 422: {
                    this.appModalService.alert(error.error);
                    return;
                }
            }
        }
        console.error(error);
    };
    AppErrorHandler = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppErrorHandler);
    return AppErrorHandler;
}());
exports.AppErrorHandler = AppErrorHandler;
//# sourceMappingURL=app.error.handler.js.map