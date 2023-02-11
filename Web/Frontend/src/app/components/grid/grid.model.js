"use strict";
exports.__esModule = true;
exports.GridModel = void 0;
var grid_parameters_model_1 = require("./grid-parameters.model");
var GridModel = (function () {
    function GridModel() {
        this.count = 0;
        this.list = new Array();
        this.parameters = new grid_parameters_model_1.GridParametersModel();
    }
    return GridModel;
}());
exports.GridModel = GridModel;
//# sourceMappingURL=grid.model.js.map