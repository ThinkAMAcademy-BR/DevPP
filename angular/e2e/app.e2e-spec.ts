import { DevPPTemplatePage } from './app.po';

describe('DevPP App', function() {
  let page: DevPPTemplatePage;

  beforeEach(() => {
    page = new DevPPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
