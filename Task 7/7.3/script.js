class Service {

    _storageArray = [];

    add(someObject) {

        var _id = this._storageArray.length.toString();
        this._storageArray.push({data: someObject, id: _id});  
    }

    getById(id) {
        let result;

        for (let i = 0; i < this._storageArray.length; i++) {

            if (this._storageArray[i].id == id) {
                return this._storageArray[i].data;
            }            
        }

        return null;
    }

    getAll() {
        let _result = []

        for (let i = 0; i < this._storageArray.length; i++) {
            _result[i] = this._storageArray[i].data;
        }

        return _result;
    }

    deleteById(id) {

        let _deleted = this.getById(id);

        this._storageArray.splice(id, 1);

        return _deleted;
    }

    updateById(id, data) {

        this._storageArray[id].data = data;
    }

    // про replaceById 1 параметр указан. Не понял задачи :(
}

var storage = new Service();