import "./ToggleItem.css";
import componentType from "../../shared/const";
import { useContext } from "react";
import { MenuContext } from "../../context/MenuProvider";

const ToggleItem = (props) => {
  const {
    services: { menuItemService },
  } = useContext(MenuContext);

  const toggle = props.toggle;
  const toggleItems = menuItemService.get(
    props.menuItems,
    toggle.id,
    componentType.Toggle
  );

  return (
    <div className="thumbnail">
      <div className="caption">
        <h3>{toggle.title}</h3>
        <ul className="toggle-item">
          {(!toggleItems || toggleItems.length === 0) && <p>No items found</p>}
          {toggleItems &&
            toggleItems.length > 0 &&
            toggleItems.map((toggleItem) => {
              return (
                <li key={toggleItem.id}>
                  <a className="toggle-item__item" href={toggleItem.link}>
                    {toggleItem.title}
                  </a>
                </li>
              );
            })}
        </ul>
      </div>
    </div>
  );
};

export default ToggleItem;
