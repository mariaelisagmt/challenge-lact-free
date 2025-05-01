import Logo from '../logo';
import './style.css';

function Header() {
    return (
        <div className='header'>
            <Logo />
            <ul> 
                <li>
                    Criar desafio
                </li>
            </ul>
        </div>
    );
}

export default Header;