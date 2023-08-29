export default class MenuService {
    get(userId) {
        //return fetch("https://localhost:7084/api/menu/admin/ao/learner/manager")
        return fetch(`/Litmos/MegaNav/Menu/${userId}`)
            .then((response) => response.json())
            .then((data) => {
                console.log('data url',data)
                return data;
            });
    }
}