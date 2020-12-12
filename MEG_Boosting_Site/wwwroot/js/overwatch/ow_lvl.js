$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            LevelPrice: 0,
            PlatformPrice: 1,
            PriceTotal: 0
        },
        watch: {
            LevelPrice: function () {
                this.PriceTotal = this.LevelPrice * this.PlatformPrice
            },
            PlatformPrice: function () {
                this.PriceTotal = this.LevelPrice * this.PlatformPrice
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
                        price.PlatformPrice = 0
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