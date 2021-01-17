import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import {Nav} from 'react-bootstrap';
import {Navbar} from 'react-bootstrap';
import {NavDropdown} from 'react-bootstrap';
import { BrowserRouter as Router, Route, Switch, Link } from 'react-router-dom';
import Home from './Components/Home';

function App() {
  return (
    <div className="App">
      <Router>

        <header className="App-header">
          <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark" fixed="top">
            <Switch>

            <Route exact path="/">
              <Link to="/">
                <Navbar.Brand>Milhie création</Navbar.Brand>
              </Link>
              <Home/>
            </Route>
            <Navbar.Toggle aria-controls="responsive-navbar-nav" />
            <Navbar.Collapse id="responsive-navbar-nav">
              <Nav className="mr-auto">
                
                <Nav.Link href="#lifeTree">Arbres de vie</Nav.Link>
                <NavDropdown title="Bijoux" id="collasible-nav-dropdown">
                  <NavDropdown.Item href="#action/3.1">Bagues</NavDropdown.Item>
                  <NavDropdown.Item href="#action/3.2">Bracelets</NavDropdown.Item>
                  <NavDropdown.Item href="#action/3.3">Colliers</NavDropdown.Item>
                  <NavDropdown.Divider />
                  <NavDropdown.Item href="#action/3.4">Pendentifs</NavDropdown.Item>
                </NavDropdown>
                <NavDropdown title="Décorations" id="collasible-nav-dropdown">
                  <NavDropdown.Item href="#action/4.1">Dreamcatcher</NavDropdown.Item>
                  <NavDropdown.Item href="#action/4.2">Décorations murales</NavDropdown.Item>
                  <NavDropdown.Item href="#action/4.3">Décorations de mariage</NavDropdown.Item>
                  <NavDropdown.Divider />
                  <NavDropdown.Item href="#action/3.4">Autres</NavDropdown.Item>
                </NavDropdown>
              </Nav>
              <Nav>
                <Nav.Link href="#deets">More deets</Nav.Link>
                <Nav.Link  href="#memes">
                  Dank memes
                </Nav.Link>
              </Nav>
            </Navbar.Collapse>
            </Switch>
          </Navbar>

        </header>
      </Router>
    </div>
  );
}

export default App;
