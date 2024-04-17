import "./navbar.scss";

const Navbar = () => {
  return (
    <div className="navbar">
      <div className="logo">
        <span>Dien Quang</span>
      </div>
      <div className="icons">
        <img src="/search.svg" alt="" className="searchIcon" />
        <img src="/app.svg" alt="" className="appIcon" />
        <img src="/expand.svg" alt="" className="expandIcon" />
        <div className="notification">
          <img src="/notifications.svg" alt="" />
          <span>22</span>
        </div>
        <div className="user">
        <img src="profile.svg" alt="" className="adminIcon"></img>
          <span>ADMIN</span>
        </div>
        <img src="/settings.svg" alt="" className="icon" />
      </div>
    </div>
  );
};

export default Navbar;
