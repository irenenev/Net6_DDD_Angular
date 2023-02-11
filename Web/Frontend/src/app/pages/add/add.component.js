"use strict";
exports.__esModule = true;
exports.AddComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var router_1 = require("@angular/router");
var AddComponent = (function () {
    function AddComponent(filmService, formBuilder, router) {
        this.filmService = filmService;
        this.formBuilder = formBuilder;
        this.router = router;
        this.form = new forms_1.FormGroup({
            title: new forms_1.FormControl(''),
            year: new forms_1.FormControl(2000),
            poster: new forms_1.FormControl(''),
            genre: new forms_1.FormControl(''),
            plot: new forms_1.FormControl(''),
            actors: new forms_1.FormControl(''),
            language: new forms_1.FormControl(''),
            country: new forms_1.FormControl('')
        });
        this.submitted = false;
    }
    AddComponent.prototype.ngOnInit = function () {
        this.form = this.formBuilder.group({
            title: ['', [forms_1.Validators.required, forms_1.Validators.maxLength(100)]],
            year: [2000, [forms_1.Validators.required, forms_1.Validators.pattern('^[0-9]{4}$')]],
            poster: ['', [forms_1.Validators.required, forms_1.Validators.maxLength(200)]],
            genre: ['', [forms_1.Validators.required, forms_1.Validators.maxLength(50)]],
            plot: ['', forms_1.Validators.maxLength(1000)],
            actors: ['', forms_1.Validators.maxLength(200)],
            language: ['', forms_1.Validators.maxLength(50)],
            country: ['', forms_1.Validators.maxLength(50)]
        });
    };
    Object.defineProperty(AddComponent.prototype, "f", {
        get: function () {
            return this.form.controls;
        },
        enumerable: false,
        configurable: true
    });
    AddComponent.prototype.add = function () {
        var _this = this;
        this.submitted = true;
        if (this.form.invalid)
            return;
        this.filmService.add(this.form.value).subscribe(function (id) {
            _this.router.navigate(["/film/detail/" + id]);
        });
    };
    tslib_1.__decorate([
        core_1.Input()
    ], AddComponent.prototype, "f");
    AddComponent = tslib_1.__decorate([
        core_1.Component({
            selector: 'app-add',
            templateUrl: './add.component.html',
            standalone: true,
            imports: [
                common_1.CommonModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                router_1.RouterModule
            ]
        })
    ], AddComponent);
    return AddComponent;
}());
exports.AddComponent = AddComponent;
//# sourceMappingURL=add.component.js.map