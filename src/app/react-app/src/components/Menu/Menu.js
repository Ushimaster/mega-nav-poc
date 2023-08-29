import "./Menu.css";
import MenuItem from "../MenuItem/MenuItem";

const Menu = (props) => {
  //Variable
  const menuItems = props.menuItems;

  const menuChangeHandler = (item) => {
    props.onChangeMenu(item);
  };

  return (
    <ul className="nav navbar-nav menu">
      {menuItems.map((item) => (
        <MenuItem key={item.id} item={item} onChangeMenu={menuChangeHandler} />
      ))}
    </ul>
  );
};

export default Menu;
