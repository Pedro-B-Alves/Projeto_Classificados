import styled from 'styled-components';

export const AdPageWrapper = styled.div`
  display: flex;
  flex: 1;
  flex-direction: column;

  .ad-page-container {
    width: 1200px;
    margin: 64px auto 0;
  }

  .ad-page-card {
    width: 100%;
    background-color: #fff;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 48px;
    border-radius: 12px;

    .ad-page-left-content {
      width: 48%;
      color: #2f2e41;
      display: flex;
      flex-direction: column;
      justify-content: space-between;
      gap: 24px;

      .ad-page-title {
        font-size: 36px;
        /* text-transform: capitalize; */
      }

      .ad-page-price {
        color: #ffb326;
      }

      .ad-page-info-subtitle {
        display: block;
        font-weight: 600;
        margin-bottom: 12px;
      }

      .ad-page-avatar {
        display: flex;
        align-items: center;
        gap: 24px;

        span {
          font-weight: 500;
        }
      }
    }

    .ad-page-right-content {
      width: 600px;
      .ad-page-image {
        width: 100%;
        height: 100%;
        padding: 24px;
        object-fit: cover;
        border-radius: 38px;
      }
    }

    .ad-page-subtitle {
      color: #2f2e41;
      font-size: 24px;
    }
  }
`;
