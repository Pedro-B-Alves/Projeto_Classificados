import styled from 'styled-components';

export const HeaderWrapper = styled.header`
  background: #55495f;
  display: flex;
  align-items: center;
  justify-content: center;
  height: 95px;
  h1 {
    color: white;
    font-family: Lemon;
  }
  a {
    font-size: 16px;
    font-family: 'Poppins';
    text-decoration: none;
    color: #ffffff;
    /* padding: 0px 17px; */
  }
  a:hover {
    color: #ffb326;
  }
  .divLogo {
    display: flex;
    align-items: center;
    border-color: red;
  }
  .contentAreaHeader {
    display: flex;
    flex-direction: column;
    width: 1200px;
  }
  .firstBlock {
    display: flex;
    justify-content: space-between;
  }
  .header-avatar {
    span {
      font-weight: 600;
      color: #fff;
    }
  }
`;
