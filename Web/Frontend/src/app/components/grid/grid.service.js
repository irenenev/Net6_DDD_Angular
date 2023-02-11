"use strict";
exports.__esModule = true;
exports.GridService = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var filters_model_1 = require("./filter/filters.model");
var order_model_1 = require("./order/order.model");
var page_model_1 = require("./page/page.model");
var GridService = (function () {
    function GridService(http) {
        this.http = http;
    }
    GridService.prototype.get = function (url, parameters) {
        return this.http.get(url + this.queryString(parameters));
    };
    GridService.prototype.queryString = function (parameters) {
        var _a, _b, _c, _d;
        var url = "?";
        parameters.page = (_a = parameters.page) !== null && _a !== void 0 ? _a : new page_model_1.PageModel();
        url += "page.index=" + parameters.page.index + "&";
        url += "page.size=" + parameters.page.size + "&";
        parameters.order = (_b = parameters.order) !== null && _b !== void 0 ? _b : new order_model_1.OrderModel();
        url += "order.property=" + ((_c = parameters.order.property) !== null && _c !== void 0 ? _c : "") + "&";
        url += "order.ascending=" + parameters.order.ascending + "&";
        parameters.filters = (_d = parameters.filters) !== null && _d !== void 0 ? _d : new filters_model_1.FiltersModel();
        parameters.filters.forEach(function (filter, index) {
            var _a;
            url += "filters[" + index + "].property=" + filter.property + "&";
            url += "filters[" + index + "].comparison=" + ((_a = filter.comparison) !== null && _a !== void 0 ? _a : "") + "&";
            url += "filters[" + index + "].value=" + filter.value + "&";
        });
        url = url.slice(0, url.length - 1);
        return url;
    };
    GridService = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], GridService);
    return GridService;
}());
exports.GridService = GridService;
//# sourceMappingURL=grid.service.js.map