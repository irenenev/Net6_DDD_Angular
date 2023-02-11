"use strict";
exports.__esModule = true;
exports.GridParametersModel = void 0;
var filters_model_1 = require("./filter/filters.model");
var order_model_1 = require("./order/order.model");
var page_model_1 = require("./page/page.model");
var GridParametersModel = (function () {
    function GridParametersModel() {
        this.filters = new filters_model_1.FiltersModel();
        this.order = new order_model_1.OrderModel();
        this.page = new page_model_1.PageModel();
    }
    return GridParametersModel;
}());
exports.GridParametersModel = GridParametersModel;
//# sourceMappingURL=grid-parameters.model.js.map