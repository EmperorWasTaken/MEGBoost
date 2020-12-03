$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            LevelPrice: 0,
            PlatformPrice: 0,
            PriceTotal: 0
        },
        watch: {
            LevelPrice: function () {
                this.PriceTotal = parseInt(this.LevelPrice) + parseInt(this.PlatformPrice)
            },
            PlatformPrice: function () {
                this.PriceTotal = parseInt(this.LevelPrice) + parseInt(this.PlatformPrice)
            },
        },

    })
    var Level = new Vue({
        el: '#Leveling',
        data: {
            Leveling: '',
        },
        watch: {
            Leveling: function (){
                switch (this.Leveling){
                    case "1":
                        price.LevelPrice = 15
                        break
                    case "2":
                        price.LevelPrice = 25
                        break
                    case "3":
                        price.LevelPrice = 45
                        break
                    case "4":
                        price.LevelPrice = 75
                        break
                    case "5":
                        price.LevelPrice = 115
                        break
                    default:
                        price.LevelPrice = 0
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
                        price.PlatformPrice = price.LevelPrice
                        break
                    case "2":
                        price.PlatformPrice = price.LevelPrice * 1.2
                        break
                    case "3":
                        price.PlatformPrice = price.LevelPrice * 1.2
                        break
                    default:
                        price.PlatformPrice = 0
                }
            }
        },
    })
})