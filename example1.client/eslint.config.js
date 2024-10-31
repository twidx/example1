import pluginVue, { rules } from "eslint-plugin-vue";
import vueTsEslintConfig from "@vue/eslint-config-typescript";

export default [
  {
    name: "app/files-to-lint",
    files: ["**/*.{ts,mts,tsx,vue}"],
    rules: {
      "vue/multi-word-component-names": "off",
      "vue/require-v-for-key": "off",
      "vue/valid-v-for": "off",
    },
  },

  {
    name: "app/files-to-ignore",
    ignores: ["**/dist/**", "**/dist-ssr/**", "**/coverage/**"],
  },

  ...pluginVue.configs["flat/essential"],
  ...vueTsEslintConfig(),
];
