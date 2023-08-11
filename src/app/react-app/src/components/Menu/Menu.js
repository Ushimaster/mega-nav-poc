import "./Menu.css";
import MenuItem from "../MenuItem/MenuItem";

const Menu = (props) => {
  //Variable
  const menuItems = props.menuItems;

  const menuChangeHandler = (item) => {
    props.onChangeMenu(item);
  };

  return (
    <div className="container-fluid menu">
      <div className="navbar-header">
        <a className="navbar-brand logo" href="#">
          <img src={require("../../assets/litmos.png")} alt="Brand"/>
        </a>
      </div>
      <ul className="nav navbar-nav menu__list">
        {menuItems.map((item) => (
          <MenuItem
            key={item.id}
            item={item}
            onChangeMenu={menuChangeHandler}
          />
        ))}
      </ul>
    </div>
  );
};

export default Menu;
