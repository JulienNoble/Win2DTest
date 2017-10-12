import { requireNativeComponent, View } from 'react-native';

const componentName = 'Win2DImageView';

const iface = {
  name: componentName,
  propTypes: {
    ...View.propTypes,
  },
};

export const Win2dImageView = requireNativeComponent(componentName, iface);
