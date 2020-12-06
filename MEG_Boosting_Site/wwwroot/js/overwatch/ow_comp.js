$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            CompPrice: 0,
            PlatformPrice: 0,
            RolePrice: 0,
            PriceTotal: 0
        },
        watch: {
            CoachingPrice: function () {
                this.PriceTotal = parseInt(this.CompPrice) + parseInt(this.PlatformPrice) + parseInt(this.RolePrice)
            },
            PlatformPrice: function () {
                this.PriceTotal = parseInt(this.CompPrice) + parseInt(this.PlatformPrice) + parseInt(this.RolePrice)
            },
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
                        price.CompPrice = 20
                        break
                    case "2":
                        price.CompPrice = 35
                        break
                    case "3":
                        price.CompPrice = 65
                        break
                    case "4":
                        price.CompPrice = 140
                        break
                    case "5":
                        price.CompPrice = 265
                        break
                    case "6":
                        price.CompPrice = 510
                        break
                    case "7":
                        price.CompPrice = 975
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
                        price.PlatformPrice = price.CompPrice
                        break
                    case "2":
                        price.PlatformPrice = price.CompPrice * 1.2
                        break
                    case "3":
                        price.PlatformPrice = price.CompPrice * 1.2
                        break
                    default:
                        price.PlatformPrice = 0
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
                        price.RolePrice = price.CompPrice
                        break
                    case "2":
                        price.RolePrice = price.CompPrice
                        break
                    case "3":
                        price.RolePrice = price.CompPrice * 1.2
                        break
                    default:
                        price.RolePrice = 0
                }
            }
        },
    })
})