import "./Dropdown.css";
import DropdownItem from "../DropdownItem/DropdownItem";

const Dropdown = (props) => {
  const dropdowns = props.dropdowns;

  return (
    <ul className="nav navbar-nav navbar-right dropdown-component">
      {dropdowns &&
        dropdowns.length > 0 &&
        dropdowns.map((dropdown) => {
          return (
            <li key={dropdown.id} className="dropdown dropdown-component__item">
              <a
                href={dropdown.link}
                data-toggle="dropdown"
                role="button"
                aria-haspopup="true"
                aria-expanded="false"
              >
                {dropdown.title} <span className="caret"></span>
              </a>
              <DropdownItem
                dropdown={dropdown}
                dropdownItems={props.dropdownItems}
              />
            </li>
          );
        })}
    </ul>
  );
};

export default Dropdown;
