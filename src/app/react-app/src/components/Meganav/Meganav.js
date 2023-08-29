import "./Meganav.css";
import Toggle from "../Toggle/Toggle";
import Menu from "../Menu/Menu";
import { useState, useContext } from "react";
import componentType from "../../shared/const";
import { MenuContext } from "../../context/MenuProvider";
import Dropdown from "../Dropdown/Dropdown";

const Meganav = (props) => {
  //Hooks
  const [togglesFiltered, setToggle] = useState();
  const {
    services: { menuItemService },
  } = useContext(MenuContext);

  const menuChangeHandler = (menu) => {
    const toggles = menuItemService.get(
      props.menuItems,
      menu.id,
      componentType.Toggle
    );
    setToggle(toggles);
  };

  let menuItemsParent;
  let dropdownsParent;

  if (props.menuItems) {
    menuItemsParent = menuItemService.get(
      props.menuItems,
      0,
      componentType.Toggle
    );

    dropdownsParent = menuItemService.get(
      props.menuItems,
      0,
      componentType.Dropdown
    );
  }

  return (
    <div className="meganav">
      <nav className="navbar navbar-default navbar-inverse meganav__navbar">
        <div className="container-fluid menu">
          <div className="navbar-header logo">
            <a className="navbar-brand logo__image" href="#">
              <img src={require("../../assets/litmos.png")} alt="Brand" />
            </a>
          </div>
          {menuItemsParent && (
            <Menu
              menuItems={menuItemsParent}
              onChangeMenu={menuChangeHandler}
            />
          )}
          {dropdownsParent && (
            <Dropdown
              dropdownItems={props.menuItems}
              dropdowns={dropdownsParent}
            />
          )}
        </div>
      </nav>
      <div className="collapse" id="navbarToggleMeganav">
        <div className="panel panel-default">
          <div className="panel-body">
            <Toggle toggles={togglesFiltered} menuItems={props.menuItems} />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Meganav;
