$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            CompPrice: 0,
            Comp2Price: 0,
            PriceTotal: 0
        },
        watch: {
            CompPrice: function () {
                this.PriceTotal = parseInt(this.CompPrice) + parseInt(this.Comp2Price)
            },
            Comp2Price: function () {
                this.PriceTotal = parseInt(this.CompPrice) + parseInt(this.Comp2Price)
            },
            PlatformPrice: function () {
                this.PriceTotal = parseInt(this.CompPrice) + parseInt(this.Comp2Price)
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
                    case "8":
                        price.Comp2Price = 35
                        break
                    case "9":
                        price.Comp2Price = 65
                        break
                    case "10":
                        price.Comp2Price = 140
                        break
                    case "11":
                        price.Comp2Price = 265
                        break
                    case "12":
                        price.Comp2Price = 510
                        break
                    case "13":
                        price.Comp2Price = 975
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
                    case "8":
                        price.Comp2Price = 35
                        break
                    case "9":
                        price.Comp2Price = 65
                        break
                    case "10":
                        price.Comp2Price = 140
                        break
                    case "11":
                        price.Comp2Price = 265
                        break
                    case "12":
                        price.Comp2Price = 510
                        break
                    case "13":
                        price.Comp2Price = 975
                        break
                    default:
                        price.CompPrice = 0
                }
            }
        },


    })
})