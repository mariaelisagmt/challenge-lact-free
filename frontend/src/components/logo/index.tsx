import logo from '../../img/logo.png';
import './style.css';

function Logo() {
    return (
        <div className='logo'>
            <img src={logo} className='img-logo' alt='logo' />
            <p><strong>Challenge Lact-Free</strong></p>
        </div>
    );
}

export default Logo;