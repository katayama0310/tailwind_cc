import * as gtag from '@lib/gtag';
import React from 'react';

type PropsType = {
  href: string,
  title: string,
}
export const PageLink = (props: PropsType) => {
  const { href, title } = props;
  const ClickEvent = () => {
    gtag.event({
      action: 'Link Click',
      category: 'Links',
      label: title,
    });
  };
  return (
    <>
      <div className='w-full h-full flex justify-center items-center'>
        <div className='relative'>
          <a
            href={href}
            title={title}
            onClick={ClickEvent}
            target='_blank'
            rel='noopener noreferrer'
          >
            <img
              src={
                'https://capture.heartrails.com/200x200/cool/delay=3?' + href
              }
              alt='linkimg'
            />
          </a>
          {title && (
            <div className='absolute bottom-0 left-0 px-3 pb-5'>
              <span className='bg-white whitespace-pre-wrap px-2 py-1 rounded text-xs'>
                {title}
              </span>
            </div>
          )}
        </div>
      </div>
    </>
  );
};
