$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            CompPrice: 0,
            Comp2Price: 0,
            PlatformPrice: 1,
            RolePrice: 1,
            PriceTotal: 0
        },
        watch: {
            CompPrice: function () {
                this.PriceTotal = this.CompPrice + this.Comp2Price * this.PlatformPrice * this.RolePrice
                this.PriceTotal = Math.round(this.PriceTotal)
            },
            Comp2Price: function () {
                this.PriceTotal = this.CompPrice + this.Comp2Price * this.PlatformPrice * this.RolePrice
                this.PriceTotal = Math.round(this.PriceTotal)
            },
            PlatformPrice: function () {
                this.PriceTotal = this.CompPrice + this.Comp2Price * this.PlatformPrice * this.RolePrice
                this.PriceTotal = Math.round(this.PriceTotal)
            },
            RolePrice: function () {
                this.PriceTotal = this.CompPrice + this.Comp2Price * this.PlatformPrice * this.RolePrice
                this.PriceTotal = Math.round(this.PriceTotal)
            }
        },
    })
    var Competitive = new Vue({
        el: '#Competitive',
        data: {
            Competitive: '',
        },
        watch: {
            Competitive: function (){
                switch (this.Competitive){
                    case "1":
                        price.CompPrice = 100
                        break
                    case "2":
                        price.CompPrice = 90
                        break
                    case "3":
                        price.CompPrice = 80
                        break
                    case "4":
                        price.CompPrice = 70
                        break
                    case "5":
                        price.CompPrice = 40
                        break
                    case "6":
                        price.CompPrice = 30
                        break
                    case "7":
                        price.CompPrice = 20
                        break
                    default:
                        price.CompPrice = 0
                }
            }
        },


    })
    var Competitive2 = new Vue({
        el: '#Competitive2',
        data: {
            Competitive2: '',
        },
        watch: {
            Competitive2: function (){
                switch (this.Competitive2){
                    case "1":
                        price.Comp2Price = 20
                        break
                    case "2":
                        price.Comp2Price = 35
                        break
                    case "3":
                        price.Comp2Price = 65
                        break
                    case "4":
                        price.Comp2Price = 140
                        break
                    case "5":
                        price.Comp2Price = 265
                        break
                    case "6":
                        price.Comp2Price = 510
                        break
                    case "7":
                        price.Comp2Price = 975
                        break
                    default:
                        price.Comp2Price = 0
                }
            }
        },


    })
    var Platform = new Vue({
        el: '#Platform',
        data: {
            Platform: '',
        },
        watch: {
            Platform: function (){
                switch (this.Platform){
                    case "1":
                        price.PlatformPrice = 1
                        PlatformName.formName = 'Bnet'
                        break
                    case "2":
                        price.PlatformPrice = 1.2
                        PlatformName.formName = 'Xbox'
                        break
                    case "3":
                        price.PlatformPrice = 1.2
                        PlatformName.formName = 'PSN'
                        break
                    default:
                        price.PlatformPrice = 1
                }
            }
        },
    })
    var Role = new Vue({
        el: '#Role',
        data: {
            Role: '',
        },
        watch: {
            Role: function (){
                switch (this.Role){
                    case "1":
                        price.RolePrice = 1
                        break
                    case "2":
                        price.RolePrice = 1
                        break
                    case "3":
                        price.RolePrice = 1.2
                        break
                    case "4":
                        price.RolePrice = 0.8
                        break
                    default:
                        price.RolePrice = 1
                }
            }
        },
    })
    var PlatformName = new Vue({
        el: '#Platformname',
        data:{
            formName:'',
            platname:'Battle.net Username:'
        },
        watch:{
            formName: function (){
                switch (this.formName){
                    case "Bnet":
                        this.platname = 'Battle.net Username:'
                        break
                    case "PSN":
                        this.platname = 'PSN Username:'
                        break
                    case "Xbox":
                        this.platname = 'Xbox Username:'
                        break
                    default:
                        this.platname = 'Battle.net Username:'
                }
            },
        }
    })
})