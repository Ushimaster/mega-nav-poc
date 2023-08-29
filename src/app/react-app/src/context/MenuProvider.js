import { createContext } from 'react';
import MenuService from '../services/MenuService';
import MenuItemService from '../services/MenuItemService';

const services = {
  menuService: new MenuService(),
  menuItemService: new MenuItemService()
};

const MenuContext = createContext();
const { Provider } = MenuContext;

const MenuProvider = ({ children }) => {
  return <Provider value={{ services }}>{children}</Provider>;
};

export { MenuContext, MenuProvider }