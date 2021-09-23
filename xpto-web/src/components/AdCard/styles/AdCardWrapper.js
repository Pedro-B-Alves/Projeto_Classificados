import styled, { css } from 'styled-components';

export const AdCardWrapper = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #ffffff;
  width: 360px;
  border-radius: 12px;
  color: #333;

  .footerCard {
    display: flex;
    align-items: center;
    text-align: center;
    width: 100%;
    padding: 12px 24px;
    justify-content: space-between;
    background-color: #fff7ea;
    margin-top: 10px;
    border-radius: 0 0 12px 12px;
  }
  .interests {
    display: flex;
    align-items: center;
    justify-content: center;
  }
  .interests img {
    width: 25px;
    height: 25px;
    margin-left: 4px;
  }
  .image {
    width: 100%;
    height: 100%;
    padding: 24px;
    object-fit: cover;
    border-radius: 38px;
  }
  .contentTextInfo p,
  .contentTextInfo h2 {
    padding: 0 24px;
  }
  .contentTextInfo h2 {
    font-size: 24px;
  }
  .contentTextInfo p {
    font-size: 16px;
  }
`;
