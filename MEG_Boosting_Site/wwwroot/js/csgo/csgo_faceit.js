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
                this.PriceTotal = this.CompPrice + this.Comp2Price
            },
            Comp2Price: function () {
                this.PriceTotal = this.CompPrice + this.Comp2Price
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
                        price.CompPrice = 200
                        break
                    case "2":
                        price.CompPrice = 190
                        break
                    case "3":
                        price.CompPrice = 180
                        break
                    case "4":
                        price.CompPrice = 170
                        break
                    case "5":
                        price.CompPrice = 160
                        break
                    case "6":
                        price.CompPrice = 150
                        break
                    case "7":
                        price.CompPrice = 140
                        break
                    case "8":
                        price.CompPrice = 130
                        break
                    case "9":
                        price.CompPrice = 120
                        break
                    case "10":
                        price.CompPrice = 110
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
                        price.Comp2Price = 10
                        break
                    case "2":
                        price.Comp2Price = 20
                        break
                    case "3":
                        price.Comp2Price = 30
                        break
                    case "4":
                        price.Comp2Price = 40
                        break
                    case "5":
                        price.Comp2Price = 50
                        break
                    case "6":
                        price.Comp2Price = 50
                        break
                    case "7":
                        price.Comp2Price = 100
                        break
                    case "8":
                        price.Comp2Price = 150
                        break
                    case "9":
                        price.Comp2Price = 200
                        break
                    case "10":
                        price.Comp2Price = 250
                        break
                    default:

                }
            }
        },


    })
})