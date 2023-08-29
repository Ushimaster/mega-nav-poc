import "./DropdownItem.css";
import componentType from "../../shared/const";
import { useContext } from "react";
import { MenuContext } from "../../context/MenuProvider";

const DropdownItem = (props) => {
  const {
    services: { menuItemService },
  } = useContext(MenuContext);

  const dropdown = props.dropdown;
  const dropdownItems = menuItemService.get(
    props.dropdownItems,
    dropdown.id,
    componentType.Dropdown
  );

  return (
    <ul className="dropdown-menu dropdown-item">
      {dropdownItems &&
        dropdownItems.length > 0 &&
        dropdownItems.map((dropdownItem) => {
          return (
            <li key={dropdownItem.id} className="dropdown-item__item">
              <a href={dropdownItem.link}>{dropdownItem.title}</a>
            </li>
          );
        })}
    </ul>
  );
};

export default DropdownItem;
