export default class MenuItemService {
    get(menuItems, parentId, componentType) {
        return menuItems.filter((item) => item.parentId === parentId && item.componentType === componentType);
    }
}