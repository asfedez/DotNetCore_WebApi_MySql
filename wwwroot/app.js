const app = new Vue({
    el: '#app',
    data: {
        initGreeting: 'Hola desde Vue',
        url: 'https://localhost:5001/api/todo',
        itemsList: []
    },
    methods: {
        openModal: function (id) {
            const elem = document.getElementById(id);
            const instance = M.Modal.init(elem, {dismissible: false});
            instance.open();
        },
        getItems: function(){
            fetch(this.url)
                .then(data => data.json())
                    .then(data => {
                        console.log(data)
                        this.itemsList = data
                    })
        },
    },
    created() {
        this.getItems()
    },
})

