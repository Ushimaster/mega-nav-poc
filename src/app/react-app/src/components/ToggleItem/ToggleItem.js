import "./ToggleItem.css";

const ToggleItem = (props) => {
  const toggle = props.toggle;
  const toggleItems = props.menuItems.filter((item) => item.parentId === toggle.id);

  return (
    <div className="thumbnail">
      <div className="caption">
        <h3>{toggle.title}</h3>
        <ul className="menu-item">
          {(!toggleItems || toggleItems.length === 0) && <p>No items found</p>}
          {toggleItems &&
            toggleItems.length > 0 &&
            toggleItems.map((toggleItem) => {
              return (
                <li key={toggleItem.id}>
                  <a className="menu-item__item" href={toggleItem.link}>
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
