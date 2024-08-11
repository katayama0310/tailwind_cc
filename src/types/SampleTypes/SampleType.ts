export type PropsTypeSampleItem = {
  className: string;
  title?: string;
  optionStyle?: string;
  onCopy: (arg: string) => void;
};

export type PropsTypeSampleInlineItem = {
  className: string;
  title: string;
  optionStyle: string;
  onCopy: (arg: string) => void;
};

export type PropsTypeSampleBox = {
  className: string;
  dammyStyle?: string;
  size?: string;
  onCopy: (arg: string) => void;
};

export type PropsTypeSampleBoxs = {
  className: string;
  dammyStyle?: string;
  boxCount: number;
  size?: string;
  onCopy: (arg: string) => void;
  children?: any;
};

export type PropsTypeSampleFlexBoxs = {
  className: string;
  dammyStyle?: string;
  boxCount: number;
  size?: string;
  onCopy: (arg: string) => void;
  children?: any;
  childClasses: string[];
};

export type PropsTypeSampleColors = {
  onCopy: (arg: string) => void;
};

export type PropsTypeSampleFontFamilies = {
  onCopy: (arg: string) => void;
};

export type PropsTypeSampleFontStyles = {
  styleItems: string[];
  optionStyle?: string;
  baseStyle?: string;
  onCopy: (arg: string) => void;
};
