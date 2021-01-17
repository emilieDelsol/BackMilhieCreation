import React from "react";
import { Link } from "react-router-dom";

const FooterPage = () => {
  return (
    <div className="footer">
      <div className="footer-items">
        <h3 className="footer-logo">Milhie</h3>
        <p className="footer-subtitle">Milhie création </p>
      </div>
      <ul className="footer-items">
        <h3 className="sub-titles">Explore</h3>
        <li><Link to="/" className="linkFooter"> Home</Link></li>
        <li><Link to="/lifeTree" className="linkFooter"> Arbres de vie</Link></li>
        <li><Link to="/jewerly" className="linkFooter"> Bijoux</Link></li>
        <li><Link to="/decos" className="linkFooter"> Decorations</Link></li>
      </ul>
      <ul className="footer-items">
        <h3 className="sub-titles">Legal</h3>
        <li>Terms</li>
        <li>Privacy</li>
      </ul>
    </div>
  );
}

export default FooterPage;