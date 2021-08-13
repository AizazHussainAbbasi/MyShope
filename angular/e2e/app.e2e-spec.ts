import { AliFitnessAE_SPTemplatePage } from './app.po';

describe('AliFitnessAE_SP App', function() {
  let page: AliFitnessAE_SPTemplatePage;

  beforeEach(() => {
    page = new AliFitnessAE_SPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
