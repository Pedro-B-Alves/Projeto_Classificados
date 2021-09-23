import styled from 'styled-components';

export const ProfileWrapper = styled.div`
  display: flex;
  flex: 1;
  flex-direction: column;

  .profile-container {
    width: 1200px;
    margin: 64px auto 0;

    h1 {
      color: #2f2e41;
      font-weight: 700;
      font-size: 36px;
    }

    .profile-cards-container {
      width: 100%;
      display: flex;
      flex-wrap: wrap;
      justify-content: space-between;
      align-items: center;
      margin: 48px 0;
      row-gap: 24px;

      a {
        text-decoration: none;
      }
    }
  }
`;
