"use strict";(self.webpackChunkfrontend=self.webpackChunkfrontend||[]).push([[83],{83:(b,r,s)=>{s.r(r),s.d(r,{AppAuthComponent:()=>l});var d=s(8692),t=s(6985),o=s(9900);class i{disabled=!1;text;static \u0275fac=function(a){return new(a||i)};static \u0275cmp=t.Xpm({type:i,selectors:[["app-button"]],inputs:{disabled:"disabled",text:"text"},standalone:!0,features:[t.jDz],decls:2,vars:3,consts:[["type","button",1,"uk-button","uk-button-primary",3,"disabled","title"]],template:function(a,e){1&a&&(t.TgZ(0,"button",0),t._uU(1),t.qZA()),2&a&&(t.Q6J("disabled",e.disabled)("title",e.text),t.xp6(1),t.Oqu(e.text))},encapsulation:2})}var c=s(3364);class u extends c.d{autofocus=!1;class;disabled=!1;formControlName;text;constructor(){super("password")}static \u0275fac=function(a){return new(a||u)};static \u0275cmp=t.Xpm({type:u,selectors:[["app-input-password"]],inputs:{autofocus:"autofocus",class:"class",disabled:"disabled",formControlName:"formControlName",text:"text"},standalone:!0,features:[t._Bn([{provide:o.JU,useExisting:u,multi:!0}]),t.qOj,t.jDz],decls:1,vars:11,consts:[["autocomplete","off",3,"autofocus","disabled","id","name","placeholder","title","type","value","input"]],template:function(a,e){1&a&&(t.TgZ(0,"input",0),t.NdJ("input",function(v){return e.input(v)}),t.qZA()),2&a&&(t.Gre("uk-input ",e.class,""),t.Q6J("autofocus",e.autofocus)("disabled",e.disabled)("id",e.formControlName)("name",e.formControlName)("placeholder",e.text)("title",e.text)("type",e.type)("value",e.value))},dependencies:[d.ez,o.u5,o.UX],encapsulation:2})}var f=s(1606);class p{for;text;static \u0275fac=function(a){return new(a||p)};static \u0275cmp=t.Xpm({type:p,selectors:[["app-label"]],inputs:{for:"for",text:"text"},standalone:!0,features:[t.jDz],decls:2,vars:3,consts:[[1,"uk-form-label",3,"for","title"]],template:function(a,e){1&a&&(t.TgZ(0,"label",0),t._uU(1),t.qZA()),2&a&&(t.Q6J("for",e.for)("title",e.text),t.xp6(1),t.Oqu(e.text))},encapsulation:2})}var m=s(7556);class l{appAuthService;form=(0,t.f3M)(o.qu).group({login:["admin@email.com",o.kI.required],password:["admin",o.kI.required]});constructor(n){this.appAuthService=n}auth(){this.appAuthService.auth(this.form.value)}static \u0275fac=function(a){return new(a||l)(t.Y36(m.K))};static \u0275cmp=t.Xpm({type:l,selectors:[["app-auth"]],standalone:!0,features:[t.jDz],decls:11,vars:3,consts:[[1,"uk-flex","uk-flex-center","uk-child-width-1-1","uk-child-width-1-2@s","uk-child-width-1-2@m","uk-child-width-1-3@l"],[3,"formGroup"],[1,"uk-fieldset"],[1,"uk-margin"],["for","login","text","Login"],["formControlName","login","text","Login",3,"autofocus"],["for","password","text","Password"],["formControlName","password","text","Password"],[1,"uk-margin","uk-text-center"],["text","Sign in",3,"disabled","click"]],template:function(a,e){1&a&&(t.TgZ(0,"div",0)(1,"form",1)(2,"fieldset",2)(3,"div",3),t._UZ(4,"app-label",4)(5,"app-input-text",5),t.qZA(),t.TgZ(6,"div",3),t._UZ(7,"app-label",6)(8,"app-input-password",7),t.qZA(),t.TgZ(9,"div",8)(10,"app-button",9),t.NdJ("click",function(){return e.auth()}),t.qZA()()()()()),2&a&&(t.xp6(1),t.Q6J("formGroup",e.form),t.xp6(4),t.Q6J("autofocus",!0),t.xp6(5),t.Q6J("disabled",e.form.invalid))},dependencies:[d.ez,o.UX,o._Y,o.JJ,o.JL,o.sg,o.u,i,u,f.a,p],encapsulation:2})}}}]);