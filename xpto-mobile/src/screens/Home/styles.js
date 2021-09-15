import { StyleSheet } from 'react-native';
import { getStatusBarHeight } from 'react-native-iphone-x-helper';

import { theme } from '../../global/styles/theme';

export const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingHorizontal: 30,
    backgroundColor: theme.colors.background,
  },
  header: {
    width: '100%',
    flexDirection: 'row',
    alignItems: 'center',
    marginTop: getStatusBarHeight() + 32,
  },
  user: {
    flexDirection: 'row',
    // height: 28,
  },
  greeting: {
    fontFamily: theme.fonts.text500,
    fontSize: 18,
    color: theme.colors.darkText,
  },
  username: {
    fontFamily: theme.fonts.title700,
    fontSize: 18,
    color: theme.colors.darkText,
  },
  message: {
    fontFamily: theme.fonts.text400,
    color: theme.colors.darkText,
  },
  banner: {
    width: '100%',
    height: '20%',
    backgroundColor: theme.colors.primary,
    borderRadius: 12,
    marginTop: 24,
    marginBottom: 24,
    padding: 30,
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
  },
  bannerText: {
    fontFamily: theme.fonts.title700,
    fontSize: 18,
    color: theme.colors.lightText,
  },
  image: {
    width: 121,
    height: 106,
  },
  title: {
    fontFamily: theme.fonts.title600,
    fontSize: 24,
    color: theme.colors.darkText,
  },
  recentAds: {
    flexDirection: 'row',
    flexWrap: 'wrap',
  },
});
