import React from 'react';
import styles from './CohortDetails.module.css';

function CohortCard({ cohort }) {
  const isOngoing = cohort.status.toLowerCase() === 'ongoing';
  const headingStyle = {
    color: isOngoing ? 'green' : 'blue',
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{cohort.name}</h3>
      <dl>
        <dt>Started On</dt>
        <dd>{cohort.startDate}</dd>

        <dt>Current Status</dt>
        <dd>{cohort.status}</dd>

        <dt>Coach</dt>
        <dd>{cohort.coach}</dd>

        <dt>Trainer</dt>
        <dd>{cohort.trainer}</dd>
      </dl>
    </div>
  );
}

export default CohortCard;
